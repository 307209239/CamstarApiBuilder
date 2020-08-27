// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UILinkAction
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
  public class UILinkAction : UIAction
  {
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_URL")]
    protected Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_QueryStringParameters")]
    protected QueryStringParameter _QueryStringParameters;
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UILinkAction && object.Equals((object) this._URL, (object) ((UILinkAction) obj)._URL) && (object.Equals((object) this._QueryStringParameters, (object) ((UILinkAction) obj)._QueryStringParameters) && object.Equals((object) this._Name, (object) ((UILinkAction) obj)._Name)) && base.Equals(obj);
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

    public QueryStringParameter QueryStringParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryStringParameters), (object) value);
      }
      get
      {
        return (QueryStringParameter) this.PropertyGet(nameof (QueryStringParameters));
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
