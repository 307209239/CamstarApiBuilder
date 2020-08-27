// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkspaceAttribute
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;

namespace Camstar.WCF.ObjectStack
{
  [AttributeUsage(AttributeTargets.Field)]
  [Serializable]
  public class WorkspaceAttribute : Attribute
  {
    public int Sequence { get; set; }

    public string SupportedBy { get; set; }

    public string Description { get; set; }

    public string Color { get; set; }

    public WorkspaceAttribute()
    {
    }

    public WorkspaceAttribute(int sequence, string supportedBy, string description, string color)
    {
      this.Sequence = sequence;
      this.SupportedBy = supportedBy;
      this.Description = description;
      this.Color = color;
    }
  }
}
