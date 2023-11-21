namespace P01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamProgressInfo streamProgress;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamProgressInfo streamProgressInfo)
        {
            this.streamProgress = streamProgressInfo;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamProgress.BytesSent * 100) / this.streamProgress.Length;
        }
    }
}
