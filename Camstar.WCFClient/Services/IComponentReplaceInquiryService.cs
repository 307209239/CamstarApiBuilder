// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IComponentReplaceInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IComponentReplaceInquiryService
  {
    [OperationContract]
    ResultStatus GetAllIssueDetails(
      UserProfile userProfile,
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Parameters parameters,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Parameters parameters,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ComponentReplaceInquiryMethod[] methods,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result);
  }
}
