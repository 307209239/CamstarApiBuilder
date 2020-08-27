// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowActivityChanges
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
  public class UIPageFlowActivityChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_Content")]
    protected Primitive<string> _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActivityChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPageFlowActivityChanges && object.Equals((object) this._Content, (object) ((UIPageFlowActivityChanges) obj)._Content) && (object.Equals((object) this._ObjectToChange, (object) ((UIPageFlowActivityChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((UIPageFlowActivityChanges) obj)._ListItemToChange)) && object.Equals((object) this._Name, (object) ((UIPageFlowActivityChanges) obj)._Name) && base.Equals(obj);
    }

    public Primitive<string> Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Content));
      }
    }

    public NamedSubentityRef ObjectToChange
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

    public NamedSubentityRef ListItemToChange
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
