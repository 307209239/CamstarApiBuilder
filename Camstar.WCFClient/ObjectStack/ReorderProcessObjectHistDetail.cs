// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReorderProcessObjectHistDetail
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
  public class ReorderProcessObjectHistDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistDetail_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ReorderProcessObjectHistDetail_ProcessObject")]
    protected NamedSubentityRef _ProcessObject;

    public override bool Equals(object obj)
    {
      return obj is ReorderProcessObjectHistDetail && object.Equals((object) this._ExportImportKey, (object) ((ReorderProcessObjectHistDetail) obj)._ExportImportKey) && (object.Equals((object) this._Sequence, (object) ((ReorderProcessObjectHistDetail) obj)._Sequence) && object.Equals((object) this._ProcessObject, (object) ((ReorderProcessObjectHistDetail) obj)._ProcessObject)) && base.Equals(obj);
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

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public NamedSubentityRef ProcessObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObject), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessObject));
      }
    }
  }
}
