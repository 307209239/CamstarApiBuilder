// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UILinkActionChanges
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
  public class UILinkActionChanges : UIActionChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_URL")]
    protected Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_QueryStringParameters")]
    protected QueryStringParameterChanges _QueryStringParameters;
    [DataMember(EmitDefaultValue = false, Name = "UILinkActionChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UILinkActionChanges && object.Equals((object) this._URL, (object) ((UILinkActionChanges) obj)._URL) && (object.Equals((object) this._ObjectToChange, (object) ((UILinkActionChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((UILinkActionChanges) obj)._ListItemToChange)) && (object.Equals((object) this._QueryStringParameters, (object) ((UILinkActionChanges) obj)._QueryStringParameters) && object.Equals((object) this._Name, (object) ((UILinkActionChanges) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<string> URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (URL));
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

    public QueryStringParameterChanges QueryStringParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryStringParameters), (object) value);
      }
      get
      {
        return (QueryStringParameterChanges) this.PropertyGet(nameof (QueryStringParameters));
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
