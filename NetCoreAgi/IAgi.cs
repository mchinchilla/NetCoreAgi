using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAgi
{
    public interface IAgi
    {
        /*        Commands        */
        Task<ICommandResponse> answer();
        Task<ICommandResponse> channel_status(string channel = "");
        Task<ICommandResponse> database_del(string family, string key);
        Task<ICommandResponse> database_deltree(string family, string key);
        Task<ICommandResponse> database_get(string family, string key);
        Task<ICommandResponse> database_put(string family, string key, string value);
        Task<ICommandResponse> set_global_var(string variable_name, string value);
        Task<ICommandResponse> set_var(string variable_name, string value);
        Task<ICommandResponse> exec(string application, string options);
        Task<ICommandResponse> get_data(string filename, int timeout, int? max_digits = null);
        Task<ICommandResponse> get_variable(string variable_name, bool get_value = false);
        Task<ICommandResponse> get_fullvariable(string variable_name, bool channel = false, bool get_value = false);
        Task<ICommandResponse> hangup(string channel = "");
        Task<ICommandResponse> noop(string message = "");
        Task<ICommandResponse> receive_char(int timeout = -1);
        Task<ICommandResponse> record_file(string file, string format, string eescape_digits = "", int timeout = -1, int? offset = null, bool beep = false, int? silence = null);
        Task<ICommandResponse> say_digits(int digits, string eescape_digits = "");
        Task<ICommandResponse> say_number(int number, string eescape_digits = "");
        Task<ICommandResponse> say_phonetic(string text, string eescape_digits = "");
        Task<ICommandResponse> say_time(int? time = null, string eescape_digits = "");
        Task<ICommandResponse> send_image(string image);
        Task<ICommandResponse> send_text(string text);
        Task<ICommandResponse> set_autohangup(int? time = 0);
        Task<ICommandResponse> set_callerid(string cid);
        Task<ICommandResponse> set_context(string context);
        Task<ICommandResponse> set_extension(string extension);
        Task<ICommandResponse> set_music(bool enable = true, string moh_class = "");
        Task<ICommandResponse> set_priority(int priority);
        Task<ICommandResponse> set_variable(string variable, string value);
        Task<ICommandResponse> stream_file(string filename, string eescape_digits = "", int offset = 0);
        Task<ICommandResponse> tdd_mode(string settings);
        Task<ICommandResponse> verbose(string message, int level = 1);
        Task<ICommandResponse> wait_for_digit(int timeout = -1);
        /*        Applications        */
        Task<ICommandResponse> exec_absolutetimeout(int seconds = 0);
        Task<ICommandResponse> exec_agi(string command, string args);
        Task<ICommandResponse> exec_setlanguage(string language = "en");
        Task<ICommandResponse> exec_enumlookup(string exten);
        Task<ICommandResponse> exec_dial(string type, string identifier, int? timeout = null, string options = null, string url = null);
        Task<ICommandResponse> exec_goto(string a, string b = null, string c = null);
        Task<ICommandResponse> fastpass_say_digits(string buffer, int digits, string escape_digits = "");
        Task<ICommandResponse> fastpass_say_phonetic(string buffer, string text, string escape_digits = "");
        Task<ICommandResponse> fastpass_say_time(string buffer, int? time = null, string escape_digits = "");
        Task<ICommandResponse> fastpass_stream_file(string buffer, string filename, string escape_digits = "", int? offset = 0);
        Task<ICommandResponse> fastpass_text2wav(string buffer, string text, string escape_digits = "", int? frequency = 8000);
        Task<ICommandResponse> fastpass_swift(string buffer, string text, string escape_digits = "", int? frequency = 8000, int? voice = null);
        Task<ICommandResponse> fastpass_say_punctuation(string buffer, string text, string escape_digits = "", int? frequency = 8000);
        Task<ICommandResponse> fastpass_get_data(string buffer, string filename, int? timeout = null, int? max_digits = null);
        Task<ICommandResponse> setContext(string context, string extension = "s", int prioriry = 1);
        Task<ICommandResponse> evaluate(string command);
        Task<ICommandResponse> conlog(string message, int verbose = 1);
        IDictionary<string, string> get_channel_variables();
    }
}
