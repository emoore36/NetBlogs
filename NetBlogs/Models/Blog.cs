namespace NetBlogs.Models
{
    public class Blog
    {

        public Blog()
        {
            Title = "Lorem Ipsum (Dolor Sit Amet)";
            Subtitle = "Lorem ipsum dolor sit amet...";
            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi lobortis sit amet justo ac tincidunt. Donec rhoncus mollis diam non laoreet. Donec ut lacinia sem, eget varius libero. Sed eu sodales nunc, id rhoncus massa. Cras imperdiet ut orci non tempus. Proin ac sem odio. Proin ac mi quis nulla dictum feugiat vitae eu est. In ut ligula non nisl faucibus tincidunt vel ac justo. Duis felis sapien, tincidunt ut lacus vitae, ultrices accumsan nisi. Nam sed magna vitae erat tincidunt pulvinar nec ut sapien. Phasellus ex elit, congue eget odio nec, posuere pretium odio. Aenean consequat turpis justo, ut ultricies urna pharetra vitae. Aenean vestibulum metus lectus, eget convallis magna rutrum malesuada.\r\n\r\nAliquam rutrum mauris eros, eget iaculis velit aliquam vel. Vivamus ac nisl convallis eros tincidunt tempus in a lorem. Nam porta ligula sed blandit fringilla. Nunc quis gravida nunc. Fusce vitae faucibus odio. Mauris molestie, purus sit amet dignissim pretium, erat augue ultrices ante, nec sodales elit nibh in sem. Nulla facilisi. Proin eleifend, dolor ut volutpat porta, sapien nisi laoreet diam, at iaculis augue libero suscipit nunc.\r\n\r\nPraesent arcu mauris, consectetur consequat cursus et, pretium vel orci. Sed lacus purus, viverra sed viverra tristique, laoreet sit amet erat. Etiam vulputate libero et ornare accumsan. In at sollicitudin lectus, a ullamcorper felis. Quisque ornare odio ac malesuada pulvinar. Fusce faucibus luctus tortor ut porta. Proin purus metus, semper nec consequat id, sagittis vel arcu. Morbi accumsan purus lacus, nec convallis libero tincidunt et. Suspendisse fringilla purus vitae pulvinar congue. Donec id semper ex, eu hendrerit nisl. Aliquam est est, rhoncus id nisi nec, lobortis maximus ligula. Mauris est justo, interdum vitae gravida sit amet, fermentum vel nisi. Quisque euismod tellus massa, semper interdum ex eleifend sit amet. Quisque sodales cursus suscipit.\r\n\r\nVivamus nisi sapien, bibendum at varius laoreet, blandit quis velit. Mauris volutpat augue massa, non sagittis mi cursus et. Curabitur quis imperdiet neque, vel aliquam tortor. Pellentesque a semper eros, at pellentesque elit. Nam suscipit imperdiet nibh in rutrum. Nunc rutrum vulputate mi, sollicitudin facilisis metus. Vestibulum rhoncus placerat risus, ac finibus magna ullamcorper at. Praesent egestas elit rhoncus blandit dignissim.\r\n\r\nSuspendisse sollicitudin ante vitae urna volutpat, vitae pellentesque metus aliquet. Donec at suscipit ante. Sed a diam eu tortor aliquet blandit eget sed nibh. Phasellus pulvinar ligula quis ultrices ullamcorper. Mauris sagittis hendrerit felis, ac luctus turpis vehicula sit amet. Fusce at erat vulputate, feugiat ante eu, tempus leo. Maecenas sit amet lobortis risus, sit amet elementum magna. Cras egestas nunc vel viverra euismod. Morbi at rhoncus nisi, nec iaculis ex.";
            Author = "";
            Created = new(1970, 1, 1, 0, 0, 0);
            LastUpdated = new(1970, 1, 1, 0, 0, 0);
        }

        public Blog(int id, string title, string subtitle, string content, string author, DateTime created, DateTime lastUpdated)
        {
            Id = id;
            Title = title;
            Subtitle = subtitle;
            Content = content;
            Author = author;
            Created = created;
            LastUpdated = lastUpdated;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTime Created { get; set; }

        public DateTime LastUpdated { get; set; }

        public override string ToString()
        {
            return $"Blog[Id={Id},Title={Title},Subtitle={Subtitle},Content={Content},Author={Author},Created={Created},LastUpdated={LastUpdated}]";
        }
    }
}
