// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PMStatusChanges
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
  public class PMStatusChanges : CurrentResourceStatusChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PMStatusChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PMStatusChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is PMStatusChanges && object.Equals((object) this._ListItemToChange, (object) ((PMStatusChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((PMStatusChanges) obj)._ObjectToChange) && base.Equals(obj);
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
