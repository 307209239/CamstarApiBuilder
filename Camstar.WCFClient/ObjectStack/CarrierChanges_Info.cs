// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CarrierChanges_Info
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
  public class CarrierChanges_Info : ResourceChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Info_ResourceFamily")]
    protected new Info _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Info_ChildResources")]
    protected new Info _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Info_ParentResource")]
    protected new Info _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CarrierChanges_Info_Name")]
    protected new Info _Name;

    public new Info ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceFamily));
      }
    }

    public new Info ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildResources));
      }
    }

    public new Info ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentResource));
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
