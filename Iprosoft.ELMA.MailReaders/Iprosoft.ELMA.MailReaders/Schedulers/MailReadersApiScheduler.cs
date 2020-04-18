using EleWise.ELMA;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using Iprosoft.ELMA.MailReaders.Services;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Iprosoft.ELMA.MailReaders.Schedulers
{
    [Component(Type = ComponentType.WebServer)]
    public class MailReadersApiScheduler : ISchedulerJobRepository
    {
        public ICollection<ISchedulerJob> GetSchedulerJobs()
        {
            return new List<ISchedulerJob> { new MailReadersApiJob() };
        }

        private class MailReadersApiJob : SchedulerJobBase
        {
            public override ITrigger Trigger { get; }
            public override ICollection<IJob> Jobs { get; }
            public override Guid? OwnerUid => Owneri.Trigguid;

            public MailReadersApiJob()
            {
                Trigger = new NthIncludedDayTrigger(
                    new NthIncludedDaySettings
                    {
                        ScheduleType = ScheduleType.Daily,
                        DailySettings = new DailySettings
                        {
                            EveryDay = 1,
                            OnlyWorkDays = true
                        },
                        RepeatSettings = new RepeatSettings
                        {
                            Enabled = true,
                            RepeatEvery = TimeSpan.FromMinutes(15),
                            RepeatTo = TimeSpan.FromHours(9)
                        },
                        StartDate = DateTime.Today.AddHours(8).AddMinutes(30)
                    },
                    Locator.GetService<IProductionCalendarService>())
                {
                    Name = SR.T("Триггер проверки почты через Api"),
                    Id = new Guid("56F6DF69-FFA3-4E24-8501-2E38020066AF")
                };

                Jobs = new List<IJob> { new JobImpl() };
            }
            private class JobImpl : IJob
            {
                public Guid Id => new Guid("795385DE-F669-41E6-81DA-9DDDEB03895A");
                public string Name => SR.T("Обновление непрочитанных писем чере Api");
                public Image Icon { get; }

                public JobResult Do(DateTime dateToRun)
                {
                    try
                    {
                        Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(() =>
                        {
                            var mailReadersService = Locator.GetServiceNotNull<IMailReadersService>();
                            mailReadersService.RunProcessesMailMassagesApi();
                        });
                        return new JobResult
                        {
                            Status = JobStatus.Success,
                            Information = SR.T("Успешно выполнено"),
                            NoSaveResult = true
                        };
                    }
                    catch (Exception ex)
                    {
                        return new JobResult
                        {
                            Status = JobStatus.Fail,
                            ErrorDescription = ex.StackTrace,
                            Information = SR.T($"Ошибка выполнения - {ex.Message}"),
                            NoSaveResult = false
                        };
                    }
                }
            }
        }
    }
    [Component]
    public class Owneri : ISchedulerTaskOwner
    {

        public static readonly Guid Trigguid = new Guid("{C838AD99-68C1-466B-B116-F09EA6DF8387}");

        public Guid Uid => Trigguid;

        public string Name => "Планировщик для MailApi";
    }
}
