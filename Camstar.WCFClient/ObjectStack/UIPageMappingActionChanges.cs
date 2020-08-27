// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageMappingActionChanges
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
  public class UIPageMappingActionChanges : UIRedirectActionChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_MapItem")]
    protected Primitive<string> _MapItem;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingActionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPageMappingActionChanges && object.Equals((object) this._ObjectToChange, (object) ((UIPageMappingActionChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((UIPageMappingActionChanges) obj)._ListItemToChange) && object.Equals((object) this._MapItem, (object) ((UIPageMappingActionChanges) obj)._MapItem)) && object.Equals((object) this._Name, (object) ((UIPageMappingActionChanges) obj)._Name) && base.Equals(obj);
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

    public Primitive<string> MapItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MapItem), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MapItem));
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
