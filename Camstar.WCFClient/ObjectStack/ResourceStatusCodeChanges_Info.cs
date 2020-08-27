// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusCodeChanges_Info
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
  public class ResourceStatusCodeChanges_Info : UserCodeChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Info_ResourceStatusReasons")]
    protected Info _ResourceStatusReasons;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Info_ResourceState")]
    protected Info _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Info_NextTxnType")]
    protected Info _NextTxnType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Info_StatusReasons")]
    protected Info _StatusReasons;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusCodeChanges_Info_Availability")]
    protected Info _Availability;

    public Info ResourceStatusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusReasons));
      }
    }

    public Info ResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceState), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceState));
      }
    }

    public Info NextTxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextTxnType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextTxnType));
      }
    }

    public Info StatusReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusReasons), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StatusReasons));
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

    public Info Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Availability));
      }
    }
  }
}
