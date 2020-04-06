using EleWise.ELMA;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using Iprosoft.ELMA.MailReaderConf.Models;
using Iprosoft.ELMA.MailReaders.Services;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Iprosoft.ELMA.MailReaders.Schedulers
{
    [Component(Type = ComponentType.WebServer)]
    public class MailReadersScheduler : ISchedulerJobRepository
    {
        public ICollection<ISchedulerJob> GetSchedulerJobs()
        {
            return new List<ISchedulerJob> { new MailReadersJob() };
        }

        private class MailReadersJob : SchedulerJobBase
        {
            public override ITrigger Trigger { get; }
            public override ICollection<IJob> Jobs { get; }
            public override Guid? OwnerUid => Owner.Trigguid;

            public MailReadersJob()
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
                    Name = SR.T("Триггер проверки почты"),
                    Id = new Guid("170F7E29-CE96-4952-A52F-AFAD01E31353")
                };

                Jobs = new List<IJob> {new JobImpl() };
            }
            private class JobImpl : IJob
            {
                public Guid Id => new Guid("795385DE-F669-41E6-81DA-9DDDEB03895A");
                public string Name => SR.T("Обновление непрочитанных писем");
                public Image Icon { get; }

                public JobResult Do(DateTime dateToRun)
                {
                    try
                    {
                        Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(() =>
                        {
                            var mailReadersService = Locator.GetServiceNotNull<IMailReadersService>();
                            var mailRequest = InterfaceActivator.Create<IMailRequestI>();
                            mailRequest.Name = $"Новый запрос на прочтение почты";
                            mailReadersService.RunProcessesMailMassages(mailRequest);
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
    public class Owner : ISchedulerTaskOwner
    {

        public static readonly Guid Trigguid = new Guid("{0CE75F09-AB86-4837-B4F8-435A5F03E0B1}");

        public Guid Uid => Trigguid;

        public string Name => "Планировщик для Mail";
    }
}
