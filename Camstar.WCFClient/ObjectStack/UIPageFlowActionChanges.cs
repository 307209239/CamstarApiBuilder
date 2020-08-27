// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowActionChanges
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
  public class UIPageFlowActionChanges : UIRedirectActionChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_UIPageFlow")]
    protected NamedObjectRef _UIPageFlow;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPageFlowActionChanges && object.Equals((object) this._ListItemToChange, (object) ((UIPageFlowActionChanges) obj)._ListItemToChange) && (object.Equals((object) this._UIPageFlow, (object) ((UIPageFlowActionChanges) obj)._UIPageFlow) && object.Equals((object) this._ObjectToChange, (object) ((UIPageFlowActionChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((UIPageFlowActionChanges) obj)._Name) && base.Equals(obj);
    }

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef UIPageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPageFlow), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIPageFlow));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
