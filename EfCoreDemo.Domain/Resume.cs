using System;
using System.Collections.Generic;
using System.Text;

namespace EfCoreDemo.Domain
{
    /// <summary>
    /// 简历
    /// </summary>
    public class Resume
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int PlayerId { get; set; }
        public Player Player { get; set; }
    }
}
