// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SpecStatus_Info
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
  public class SpecStatus_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_Info_CompletedTxns")]
    protected Info _CompletedTxns;
    [DataMember(EmitDefaultValue = false, Name = "SpecStatus_Info_Container")]
    protected Info _Container;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public Info CompletedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedTxns), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompletedTxns));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }
  }
}
