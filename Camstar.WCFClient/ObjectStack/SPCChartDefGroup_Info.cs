// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SPCChartDefGroup_Info
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
  public class SPCChartDefGroup_Info : NamedObjectGroup_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroup_Info_Entries")]
    protected new Info _Entries;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroup_Info_Groups")]
    protected new Info _Groups;
    [DataMember(EmitDefaultValue = false, Name = "SPCChartDefGroup_Info_EntryType")]
    protected new Info _EntryType;

    public new Info Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Entries));
      }
    }

    public new Info Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Groups));
      }
    }

    public new Info EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EntryType));
      }
    }
  }
}
