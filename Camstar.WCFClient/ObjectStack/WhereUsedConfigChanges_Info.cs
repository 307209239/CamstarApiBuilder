// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WhereUsedConfigChanges_Info
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
  public class WhereUsedConfigChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_Info_WhereUsedConfigDetails")]
    protected WhereUsedConfigDetailsChanges_Info _WhereUsedConfigDetails;
    [DataMember(EmitDefaultValue = false, Name = "WhereUsedConfigChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public WhereUsedConfigDetailsChanges_Info WhereUsedConfigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfigDetails), (object) value);
      }
      get
      {
        return (WhereUsedConfigDetailsChanges_Info) this.PropertyGet(nameof (WhereUsedConfigDetails));
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
  }
}
