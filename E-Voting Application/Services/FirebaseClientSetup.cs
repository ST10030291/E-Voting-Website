namespace E_Voting_Application.Firebase
{
    using global::Firebase.Database;
    using System.Threading.Tasks;

    public class FirebaseClientSetup
    {
        private static FirebaseClient _firebaseClient;

        public static FirebaseClient InitializeFirebase()
        {
            if (_firebaseClient == null)
            {
                // Firebase Realtime Database URL
                string firebaseUrl = "https://e-voting-application-b782e-default-rtdb.firebaseio.com/";

                // Initialize Firebase client
                _firebaseClient = new FirebaseClient(firebaseUrl);
            }

            return _firebaseClient;
        }
    }
}
