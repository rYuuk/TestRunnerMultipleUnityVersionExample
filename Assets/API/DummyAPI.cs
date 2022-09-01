namespace API
{
    public class DummyAPI
    {
        public bool IsLoaded = false;

        public void Load()
        {
            IsLoaded = true;
        }

        public void UnLoad()
        {
            IsLoaded = false;
        }
    }
}
