using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace Katmer.Wenitor
{
    public class WenitorDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;

        private readonly IRepository<TargetSource, Guid> _targetSourceRepository;

        public WenitorDataSeedContributor(IGuidGenerator guidGenerator,
            IRepository<TargetSource, Guid> targetSourceRepository)
        {
            _guidGenerator = guidGenerator;
            _targetSourceRepository = targetSourceRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            await _targetSourceRepository.InsertAsync(
                new TargetSource()
                {
                    Name = "Github Trending",
                    Title = "Github Trending",
                    WebURL = "https://github.com/trending",
                    TargetSelectors = new List<TargetSelector>()
                    { 
                        new TargetSelector()
                        { 
                            SelectorType = SelectorType.CSSSelector,
                            ExpressionString = ">div.application-main>main>div.explore-pjax-container.container-lg.p-responsive.pt-6>div.Box>div:nth-child(2)>article.Box-row:nth-child(1)",
                        }
                    },
                    ScheduleCheck = new ScheduleCheck()
                    { 
                        ScheduleType = ScheduleType.Interval,
                        Duration = 15,
                    },
                    Alerts = new List<Alert>()
                    { 
                        new Alert()
                        { 
                            AlertType = AlertType.Telegram,
                            Detail1 = "999-999-99-99"
                        }
                    }
                });

            await _targetSourceRepository.InsertAsync(
                new TargetSource()
                {
                    Name = "Github Project Stars",
                    Title = "Github Project Stars",
                    WebURL = "https://github.com/KatmerTeam",
                    TargetSelectors = new List<TargetSelector>()
                    {
                        new TargetSelector()
                        {
                            SelectorType = SelectorType.CSSSelector,
                            ExpressionString = "#org-repositories>div.col-12.col-md-8.d-md-inline-block>div.org-repos.repo-list>ul>li.public.source.d-block.py-4.border-bottom:nth-child(1)>div.text-gray.f6.mt-2>span.no-wrap>relative-time.no-wrap",
                        }
                    },
                    ScheduleCheck = new ScheduleCheck()
                    {
                        ScheduleType = ScheduleType.Interval,
                        Duration = 20,
                    },
                    Alerts = new List<Alert>()
                    {
                        new Alert()
                        {
                            AlertType = AlertType.SMS,
                            Detail1 = "999-999-99-99"
                        }
                    }
                });

            await _targetSourceRepository.InsertAsync(
                new TargetSource()
                {
                    Name = "ABP Last Release",
                    Title = "ABP Last Release",
                    WebURL = "https://github.com/abpframework/abp/releases",
                    TargetSelectors = new List<TargetSelector>()
                    {
                        new TargetSelector()
                        {
                            SelectorType = SelectorType.CSSSelector,
                            ExpressionString = "body > div.application-main > div > main > div.container-lg.clearfix.new-discussion-timeline.experiment-repo-nav.p-responsive > div > div.position-relative.border-top.clearfix > div:nth-child(1) > div > div.col-12.col-md-9.col-lg-10.px-md-3.py-md-4.release-main-section.commit.open.float-left > div.release-header > div > div",
                        }
                    },
                    ScheduleCheck = new ScheduleCheck()
                    {
                        ScheduleType = ScheduleType.Interval,
                        Duration = 25,
                    },
                    Alerts = new List<Alert>()
                    {
                        new Alert()
                        {
                            AlertType = AlertType.Telegram,
                            Detail1 = "999-999-99-99"
                        }
                    }
                });
        }
    }
}
