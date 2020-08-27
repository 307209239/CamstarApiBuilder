// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStatus
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
  public class SpecStatus : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_CompletedTxns")]
    protected Primitive<int>[] _CompletedTxns;
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_Container")]
    protected ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is SpecStatus && object.Equals((object) this._ExportImportKey, (object) ((SpecStatus) obj)._ExportImportKey) && (object.Equals((object) this._Spec, (object) ((SpecStatus) obj)._Spec) && this.CompareArrays((Array) this._CompletedTxns, (Array) ((SpecStatus) obj)._CompletedTxns)) && object.Equals((object) this._Container, (object) ((SpecStatus) obj)._Container) && base.Equals(obj);
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

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public Primitive<int>[] CompletedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedTxns), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (CompletedTxns));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }
  }
}
