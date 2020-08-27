// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UILinkAction_Info
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
  public class UILinkAction_Info : UIAction_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_Info_URL")]
    protected Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_Info_QueryStringParameters")]
    protected QueryStringParameter_Info _QueryStringParameters;
    [DataMember(EmitDefaultValue = false, Name = "UILinkAction_Info_Name")]
    protected new Info _Name;

    public Info URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (URL));
      }
    }

    public QueryStringParameter_Info QueryStringParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryStringParameters), (object) value);
      }
      get
      {
        return (QueryStringParameter_Info) this.PropertyGet(nameof (QueryStringParameters));
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
  }
}
