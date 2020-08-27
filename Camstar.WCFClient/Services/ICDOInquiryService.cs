// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICDOInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICDOInquiryService
  {
    [OperationContract]
    ResultStatus GetReferences(
      UserProfile userProfile,
      CDOInquiry cDOInquiry,
      CDOInquiry_Parameters parameters,
      CDOInquiry_Request request,
      out CDOInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CDOInquiry cDOInquiry,
      CDOInquiry_Parameters parameters,
      CDOInquiry_Request request,
      out CDOInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CDOInquiryMethod[] methods,
      CDOInquiry_Request request,
      out CDOInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CDOInquiry cDOInquiry,
      CDOInquiry_Request request,
      out CDOInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CDOInquiry cDOInquiry,
      CDOInquiry_Request request,
      out CDOInquiry_Result result);
  }
}
