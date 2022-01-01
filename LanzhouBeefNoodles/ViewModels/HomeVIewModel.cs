using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.ViewModels;

public class HomeVIewModel
{
    public IList<Noodle> Noodles { get; set; }
    public IList<Feedback> Feedbacks { get; set; }
}