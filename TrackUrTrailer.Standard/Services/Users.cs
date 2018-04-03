using System;
namespace TrackUrTrailer.Standard
{
    public static class Users
    {

        private static UserRole _activeRole = UserRole.Driver;

        public static UserRole ActiveRole
        {
            get => _activeRole;
            private set => _activeRole = value;
        }

        public static void LogUserIn(UserRole role)
        {
            ActiveRole = role;
        }
    }
}
