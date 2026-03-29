using AppTechnoSoft.Core.ViewModels;
using ZyloApp.Web.Data.Constants;
using ZyloApp.Web.Data.Models;
using ZyloApp.Web.Data.Models.Sites;
using Humanizer;

namespace AppTechnoSoft.Core.Mappers;

public static class SiteItemMapper
{
    public static SiteItemViewModel ToViewModel(this Section model) => new(model.Id)
    {
        Label = model.Title,
        Enabled = model.Enabled,
        Order = model.Order,
        Content = model.Content,
        Editing = false,
    };

    public static Widget ToModel(this SiteItemViewModel viewMmodel)
    {
        var model = new Widget
        {
            Id = viewMmodel.Id,
            Description = viewMmodel.Label,
            HtmlContent = viewMmodel.Content ?? "",
            Title = WidgetType.SiteItem
        };

        return model;
    }

    public static SiteItemViewModel ToViewModel(this Widget model) => new(Id: model.Id, LastUpdated: model.LastUpdated.Humanize(), UpdatedBy: model.LastUpdatedBy ?? "") 
    {
        Label = model.Description,
        Content = model.HtmlContent,
        Editing = false
    };

    public static List<SiteItemViewModel> ToViewModel(this List<Section> models)
        => [.. models.Select(x => x.ToViewModel())];

    public static List<SiteItemViewModel> ToViewModel(this List<Widget> models)
        => [.. models.Select(x => x.ToViewModel())];
}
