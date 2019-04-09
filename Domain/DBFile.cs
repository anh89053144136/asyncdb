using System;
using System.Collections.Generic;
using System.Text;

namespace asyncdb
{
    public  class File
    {
        public virtual int Id { set; get; }
        public virtual string Name { set; get; }
        public virtual DateTime CreatedDate { set; get; }
        public virtual byte[] Content { set; get; }
    }
}
