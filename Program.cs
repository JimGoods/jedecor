using Statiq.App;
using Statiq.Common;
using Statiq.Web;

await Bootstrapper
    .Factory
    .CreateWeb(args)
    .RunAsync();