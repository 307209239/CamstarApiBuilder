// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageMappingAction
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
  public class UIPageMappingAction : UIRedirectAction
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingAction_MapItem")]
    protected Primitive<string> _MapItem;
    [DataMember(EmitDefaultValue = false, Name = "UIPageMappingAction_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UIPageMappingAction && object.Equals((object) this._MapItem, (object) ((UIPageMappingAction) obj)._MapItem) && object.Equals((object) this._Name, (object) ((UIPageMappingAction) obj)._Name) && base.Equals(obj);
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
