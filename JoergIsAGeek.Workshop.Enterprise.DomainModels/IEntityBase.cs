﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoergIsAGeek.Workshop.Enterprise.DomainModels {
  public interface IEntityBase<T> {

    T Id { get; set; }


  }
}
