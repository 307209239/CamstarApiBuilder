// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IWhereUsedInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IWhereUsedInquiryService
  {
    [OperationContract]
    ResultStatus GetConfig(
      UserProfile userProfile,
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_GetConfig_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result);

    [OperationContract]
    ResultStatus GetResult_NDO(
      UserProfile userProfile,
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result);

    [OperationContract]
    ResultStatus GetResult_RO(
      UserProfile userProfile,
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Parameters parameters,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      WhereUsedInquiryMethod[] methods,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      WhereUsedInquiry whereUsedInquiry,
      WhereUsedInquiry_Request request,
      out WhereUsedInquiry_Result result);
  }
}
