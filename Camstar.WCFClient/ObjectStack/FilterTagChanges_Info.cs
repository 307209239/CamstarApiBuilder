// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FilterTagChanges_Info
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
  public class FilterTagChanges_Info : UserCodeChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_Info_InstanceID")]
    protected Info _InstanceID;
    [DataMember(EmitDefaultValue = false, Name = "FilterTagChanges_Info_Name")]
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

    public Info InstanceID
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceID));
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
