﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IGetGeneralMessageService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IGetGeneralMessageService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      GetGeneralMessage getGeneralMessage,
      GetGeneralMessage_Parameters parameters,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      GetGeneralMessageMethod[] methods,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      GetGeneralMessage getGeneralMessage,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      GetGeneralMessage getGeneralMessage,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result);
  }
}
