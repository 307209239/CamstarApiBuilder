﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Label
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Label : WCFObjectBase
  {
    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ID")]
    public int? ID { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Value")]
    public string Value { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "DefaultValue")]
    public string DefaultValue { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "LabelType")]
    public Camstar.WCF.ObjectStack.LabelType? LabelType { get; set; }

    public Label()
    {
    }

    public Label(int id)
    {
      this.ID = new int?(id);
    }

    public Label(string name)
    {
      this.Name = name;
    }
  }
}
