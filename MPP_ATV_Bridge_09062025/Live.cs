class Live
{
    protected IPlatform platform;
    public Live(IPlatform platform)
    {
        this.platform = platform;
    }
    public void StartLive()
    {
        platform.ConfigureRTMP();
        platform.AuthToken();
        platform.BroadCasting();
    }
    public void AddSubtitles()
    {
        platform.Subtitles();
    }
    public void EnableComments()
    {
        platform.Comments();
    }
}
