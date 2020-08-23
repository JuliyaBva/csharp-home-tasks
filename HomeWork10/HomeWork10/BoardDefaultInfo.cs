namespace HomeWork10
{
    public class BoardDefaultInfo
    {
        public string type;
        public string id;
        public BoardDefaultInfo(string type, string id)
        {
            this.type = type;
            this.id = id;
        }
        public virtual string Info()
        {
            return id;
        }
    }
    public class BoardAddInfo : BoardDefaultInfo
    {
        public string approval;
        public BoardAddInfo(string type, string id, string approval) : base(type, id)
        {
            this.approval = approval;
        }
        public override string Info()
        {
            return id + " " + approval;
        }
    }
}