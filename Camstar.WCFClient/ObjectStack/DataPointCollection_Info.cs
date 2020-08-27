// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollection_Info
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
  public class DataPointCollection_Info : NamedSubentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Info_Groups")]
    protected DataPointCollectionGroup_Info _Groups;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Info_Instructions")]
    protected Info _Instructions;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollection_Info_IsFrozen")]
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

    public DataPointCollectionGroup_Info Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (DataPointCollectionGroup_Info) this.PropertyGet(nameof (Groups));
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

    public Info Instructions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instructions), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instructions));
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
