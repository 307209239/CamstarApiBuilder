// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IExportImportInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IExportImportInquiryService
  {
    [OperationContract]
    ResultStatus GetStatusDetails(
      UserProfile userProfile,
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Parameters parameters,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Parameters parameters,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ExportImportInquiryMethod[] methods,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ExportImportInquiry exportImportInquiry,
      ExportImportInquiry_Request request,
      out ExportImportInquiry_Result result);
  }
}
