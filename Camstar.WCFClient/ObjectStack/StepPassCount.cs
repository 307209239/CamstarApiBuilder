// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StepPassCount
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
  public class StepPassCount : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "StepPassCount_Step")]
    protected NamedSubentityRef _Step;
    [DataMember(EmitDefaultValue = false, Name = "StepPassCount_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "StepPassCount_StepPass")]
    protected Primitive<int> _StepPass;

    public override bool Equals(object obj)
    {
      return obj is StepPassCount && object.Equals((object) this._Step, (object) ((StepPassCount) obj)._Step) && (object.Equals((object) this._ExportImportKey, (object) ((StepPassCount) obj)._ExportImportKey) && object.Equals((object) this._StepPass, (object) ((StepPassCount) obj)._StepPass)) && base.Equals(obj);
    }

    public NamedSubentityRef Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Step));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<int> StepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPass), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (StepPass));
      }
    }
  }
}
