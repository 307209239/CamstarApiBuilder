// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispatchDetailChanges_Info
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
  public class DispatchDetailChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Info_Parent")]
    protected new Info _Parent;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Info_QueryName")]
    protected Info _QueryName;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Info_DispatchType")]
    protected Info _DispatchType;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Info_EnforceDispatch")]
    protected Info _EnforceDispatch;
    [DataMember(EmitDefaultValue = false, Name = "DispatchDetailChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public new Info Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Parent));
      }
    }

    public Info QueryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QueryName));
      }
    }

    public Info DispatchType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispatchType));
      }
    }

    public Info EnforceDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (EnforceDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EnforceDispatch));
      }
    }

    public Info IsFrozen
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
