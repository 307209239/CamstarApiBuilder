// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IActionsMenuInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IActionsMenuInquiryService
  {
    [OperationContract]
    ResultStatus GetActionsMenuDetails(
      UserProfile userProfile,
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Parameters parameters,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Parameters parameters,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ActionsMenuInquiryMethod[] methods,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result);
  }
}
