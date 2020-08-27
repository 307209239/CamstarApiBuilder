// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelSummary
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class LabelSummary : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_LabelDetails")]
    protected Camstar.WCF.ObjectStack.LabelDetails[] _LabelDetails;
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_PrinterLabelDefinition")]
    protected RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary_LabelCount")]
    protected Primitive<int> _LabelCount;

    public override bool Equals(object obj)
    {
      return obj is LabelSummary && this.CompareArrays((Array) this._LabelDetails, (Array) ((LabelSummary) obj)._LabelDetails) && (object.Equals((object) this._PrinterLabelDefinition, (object) ((LabelSummary) obj)._PrinterLabelDefinition) && object.Equals((object) this._PrintQueue, (object) ((LabelSummary) obj)._PrintQueue)) && object.Equals((object) this._LabelCount, (object) ((LabelSummary) obj)._LabelCount) && base.Equals(obj);
    }

    public Camstar.WCF.ObjectStack.LabelDetails[] LabelDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.LabelDetails[]) this.PropertyGet(nameof (LabelDetails));
      }
    }

    public RevisionedObjectRef PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Primitive<int> LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LabelCount));
      }
    }
  }
}
