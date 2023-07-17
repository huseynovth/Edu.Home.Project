using EduHome.Core.Entities;

namespace EduHome.UI.ViewModels;

public class HomeVM
{
    public IEnumerable<Slider>? Sliders { get; set; }
    public IEnumerable<NoticeBoard>? NoticeBoards { get; set; }
    public IEnumerable<Blog>? Blogs { get; set; }
    public IEnumerable<Event>? Events { get; set; }
    public IEnumerable<Course>? Courses { get; set; }
    public IEnumerable<CourseCatagory>? CourseCatagorys { get; set; }
}
