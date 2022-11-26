namespace Zenboard.Common;

public static class ApiRoutes
{
    private const string Root = "zenboard/api";
    private const string Version = "v1";
    private const string BaseUrl = Root + "/" + Version;

    public static class Issue
    {
        private const string Resource = "issue";
        public const string GetAll = BaseUrl + "/" + Resource;
    }
}