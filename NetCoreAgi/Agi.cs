using System;
using System.Threading.Tasks;

namespace NetCoreAgi
{
    public class Agi : IAgi
    {
        public Agi()
        {

        }

        public Task<ICommandResponse> answer()
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> channel_status(string channel = "")
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

        public Task<ICommandResponse> fastpass_say_digits(string buffer, int digits, string scape_digits = "")
        {
            throw new NotImplementedException();
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

        public Task<ICommandResponse> record_file(string file, string format, string escape_digits = "", int timeout = -1, int? offset = null, bool beep = false, int? silence = null)
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_digits(int digits, string escape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_number(int number, string escape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_phonetic(string text, string escape_digits = "")
        {
            throw new NotImplementedException();
        }

        public Task<ICommandResponse> say_time(int? time = null, string escape_digits = "")
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

        public Task<ICommandResponse> stream_file(string filename, string escape_digits = "", int offset = 0)
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
