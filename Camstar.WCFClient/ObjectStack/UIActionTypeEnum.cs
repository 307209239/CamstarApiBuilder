// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIActionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum UIActionTypeEnum
  {
    [Metadata("Generic String", "", false, false, false, "String", 1052769, false, false, false, "UIPageRedirectActionChanges"), EnumMember, Enumeration("UIPageRedirectActionChanges")] PageRedirectAction = -771541433, // 0xD2033647
    [EnumMember, Enumeration("UICustomActionChanges"), Metadata("Generic String", "", false, false, false, "String", 1052764, false, false, false, "UICustomActionChanges")] CustomAction = -435406079, // 0xE60C3B01
    [Enumeration("UIFloatPageOpenActionChanges"), Metadata("Generic String", "", false, false, false, "String", 1052765, false, false, false, "UIFloatPageOpenActionChanges"), EnumMember] FloatPageOpenAction = -42677743, // 0xFD74CA11
    [Metadata("Generic String", "", false, false, false, "String", 1052767, false, false, false, "UIPageFlowActionChanges"), Enumeration("UIPageFlowActionChanges"), EnumMember] PageFlowRedirectAction = 357536597, // 0x154F9355
    [Metadata("Generic String", "", false, false, false, "String", 1052768, false, false, false, "UIPageMappingActionChanges"), Enumeration("UIPageMappingActionChanges"), EnumMember] PageMappingAction = 572395289, // 0x221E0F19
    [Enumeration("UILinkActionChanges"), EnumMember, Metadata("Generic String", "", false, false, false, "String", 1052766, false, false, false, "UILinkActionChanges")] LinkAction = 1412623372, // 0x5432EC0C
    [Metadata("Generic String", "", false, false, false, "String", 1052770, false, false, false, "UISubmitActionChanges"), EnumMember, Enumeration("UISubmitActionChanges")] SubmitAction = 1456357416, // 0x56CE4028
  }
}
