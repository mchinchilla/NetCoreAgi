using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAgi
{
    public class Agi : IAgi
    {
        private static IDictionary<string, string> channelVars = new Dictionary<string, string>();
        private string info = string.Empty;
        private StringBuilder input = new StringBuilder();
        private StringBuilder linebld = new StringBuilder();
        private string line = string.Empty;
        private int endOfFile = 0;

        public Agi()
        {
            channelVars = get_channel_variables();
        }

        public Task<ICommandResponse> answer()
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> channel_status(string channel = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> conlog(string message, int verbose = 1)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> database_del(string family, string key)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> database_deltree(string family, string key)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> database_get(string family, string key)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> database_put(string family, string key, string value)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> evaluate(string command)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> exec(string application, string options)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> exec_absolutetimeout(int seconds = 0)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> exec_agi(string command, string args)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> exec_dial(string type, string identifier, int? timeout = null, string options = null, string url = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> exec_enumlookup(string exten)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> exec_goto(string a, string b = null, string c = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> exec_setlanguage(string language = "en")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_get_data(string buffer, string filename, int? timeout = null, int? max_digits = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_say_digits(string buffer, int digits, string escape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_say_phonetic(string buffer, string text, string escape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_say_punctuation(string buffer, string text, string escape_digits = "", int? frequency = 8000)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_say_time(string buffer, int? time = null, string escape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_stream_file(string buffer, string filename, string escape_digits = "", int? offset = 0)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_swift(string buffer, string text, string escape_digits = "", int? frequency = 8000, int? voice = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> fastpass_text2wav(string buffer, string text, string escape_digits = "", int? frequency = 8000)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, string> get_channel_variables()
        {
            // Get channels agi variables
            
            IDictionary<string, string> chanVars = new Dictionary<string, string>();
            input = new StringBuilder();
            endOfFile = 0;
            line = string.Empty;

            while ((endOfFile = Console.In.Read()) != -1)
            {
                if ((char)endOfFile != 10)
                {
                    input.Append(((char)endOfFile).ToString());
                    linebld.Append(((char)endOfFile).ToString());
                    string s = input.ToString();
                }
                else
                {
                    line = linebld.ToString();
                    if (line == string.Empty)
                    {
                        break;
                    }
                    else
                    {
                        string[] keyPairs = line.Split(':');
                        chanVars.Add(keyPairs[0].Trim(), keyPairs[1].Trim());
                        line = string.Empty;
                        linebld.Clear();
                    }

                }
            }
            return chanVars;
        }

        public Task<ICommandResponse> get_data(string filename, int timeout, int? max_digits = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> get_fullvariable(string variable_name, bool channel = false, bool get_value = false)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> get_variable(string variable_name, bool get_value = false)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> hangup(string channel = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> noop(string message = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> receive_char(int timeout = -1)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> record_file(string file, string format, string eescape_digits = "", int timeout = -1, int? offset = null, bool beep = false, int? silence = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_digits(int digits, string eescape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_number(int number, string eescape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_phonetic(string text, string eescape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_time(int? time = null, string eescape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> send_image(string image)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> send_text(string text)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> setContext(string context, string extension = "s", int prioriry = 1)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_autohangup(int? time = 0)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_callerid(string cid)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_context(string context)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_extension(string extension)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_global_var(string variable_name, string value)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_music(bool enable = true, string moh_class = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_priority(int priority)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_var(string variable_name, string value)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> set_variable(string variable, string value)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> stream_file(string filename, string eescape_digits = "", int offset = 0)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> tdd_mode(string settings)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> verbose(string message, int level = 1)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> wait_for_digit(int timeout = -1)
        {
            throw new NotImplementedException();
        }
    }
}
