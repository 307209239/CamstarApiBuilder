// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionPointSample_Info
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
  public class DPCollectionPointSample_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_Info_DataValue")]
    protected Info _DataValue;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointSample_Info_IsFrozen")]
    protected new Info _IsFrozen;

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

    public Info DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataValue));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
