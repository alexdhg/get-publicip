// put this outside of the button's code
string externalip = new WebClient().DownloadString("http://icanhazip.com");
bool is64 = System.Environment.Is64BitOperatingSystem;

// put this inside of the buttotn's code
MessageBox.Show("(+) " + externalip, "Public IPv4"); // you can change it in whatever you want.
