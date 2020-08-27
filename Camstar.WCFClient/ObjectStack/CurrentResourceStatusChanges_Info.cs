// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentResourceStatusChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PMStatusChanges_Info))]
  [KnownType(typeof (ResourceLogChanges_Info))]
  [Serializable]
  public class CurrentResourceStatusChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Info_Reason")]
    protected Info _Reason;
    [DataMember(EmitDefaultValue = false, Name = "CurrentResourceStatusChanges_Info_Status")]
    protected Info _Status;

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Reason));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }
  }
}
