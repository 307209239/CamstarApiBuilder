// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceTypeChanges_Info
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
  public class ResourceTypeChanges_Info : UserCodeChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Info_UIPreference")]
    protected Info _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Info_ResourceStatusModel")]
    protected Info _ResourceStatusModel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceTypeChanges_Info_Name")]
    protected new Info _Name;

    public Info UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIPreference));
      }
    }

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

    public Info ResourceStatusModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusModel));
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
