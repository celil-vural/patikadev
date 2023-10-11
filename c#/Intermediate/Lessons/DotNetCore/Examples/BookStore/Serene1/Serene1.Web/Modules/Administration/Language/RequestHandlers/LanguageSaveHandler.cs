using MyRequest = Serenity.Services.SaveRequest<Serene1.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = Serene1.Administration.LanguageRow;


namespace Serene1.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}