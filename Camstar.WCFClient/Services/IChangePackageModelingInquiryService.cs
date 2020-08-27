// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangePackageModelingInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangePackageModelingInquiryService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Parameters parameters,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result);

    [OperationContract]
    ResultStatus IsChangeMgtSave(
      UserProfile userProfile,
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Parameters parameters,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangePackageModelingInquiryMethod[] methods,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangePackageModelingInquiry changePackageModelingInquiry,
      ChangePackageModelingInquiry_Request request,
      out ChangePackageModelingInquiry_Result result);
  }
}
