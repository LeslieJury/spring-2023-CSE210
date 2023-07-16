public class ListingActivity : Activity
{
    private int _track = 0;
    private List<string> _prompts = new List<string>() {
        "List some people in your life who you care about.",
        "What is your favorite thing about yourself?",
        "Describe your most recent adventure.",
        "What is your favorite show and why?",
    };

    private List<string> rPrompts = new List<string>();
    public string getRandomPrompt(){

        int temp = _track;
        _track++;
        return _prompts[temp];
    }
    public void displayPrompt() {
        Console.WriteLine("\nList as many responses you want to:");
        Console.WriteLine(getRandomPrompt());
    }
}