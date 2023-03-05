namespace DesignProject.Data
{
    public class LoginState
    {
        public bool IsLoggedIn { get; set; } = false;
        public string LibraryUser { get; set; } = string.Empty;
        public event Action? OnChange;

        public void SetLogin(bool login, string LibraryUser)
        {
            IsLoggedIn = login;
            this.LibraryUser = LibraryUser;
            NotifyStateChanged();
        }

        private void NotifyStateChanged()
        {
            OnChange?.Invoke();
        }
    }
}
