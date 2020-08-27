// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.InspectionLevelMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class InspectionLevelMaintService : NamedDataObjectMaintBase
  {
    public InspectionLevelMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IInspectionLevelMaintService), userProfile);
    }

    public ResultStatus Delete(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).Delete(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus Delete(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.Delete(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus Delete(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.Delete(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).Freeze(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus Freeze(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.Freeze(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus Freeze(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.Freeze(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).GetWIPMsgs(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.GetWIPMsgs(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.GetWIPMsgs(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).Load(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus Load(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.Load(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus Load(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.Load(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_LoadESigDetails_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).LoadESigDetails(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.LoadESigDetails, (InspectionLevelMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((InspectionLevelMaint) null, (InspectionLevelMaint_LoadESigDetails_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.LoadESigDetails(inspectionLevelMaint, (InspectionLevelMaint_LoadESigDetails_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.LoadESigDetails(inspectionLevelMaint, (InspectionLevelMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).New(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus New(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.New(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus New(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.New(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).NewCopy(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus NewCopy(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.NewCopy(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus NewCopy(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.NewCopy(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).SaveAs(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus SaveAs(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.SaveAs(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus SaveAs(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.SaveAs(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Parameters parameters,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).UnFreeze(this._UserProfile, inspectionLevelMaint, parameters, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(inspectionLevelMaint, InspectionLevelMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) inspectionLevelMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((InspectionLevelMaint) null, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(InspectionLevelMaint inspectionLevelMaint)
    {
      return this.UnFreeze(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus UnFreeze(
      InspectionLevelMaint inspectionLevelMaint,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.UnFreeze(inspectionLevelMaint, (InspectionLevelMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.Delete((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_LoadESigDetails_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.New((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.Load((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject inspectionLevelMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((InspectionLevelMaint) inspectionLevelMaint, (InspectionLevelMaint_Parameters) parameters, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      try
      {
        InspectionLevelMaintMethod[] methods = new InspectionLevelMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IInspectionLevelMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      InspectionLevelMaint cdo,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      try
      {
        return ((IInspectionLevelMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((InspectionLevelMaint) cdo, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.GetEnvironment((InspectionLevelMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      InspectionLevelMaint cdo,
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      result = (InspectionLevelMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInspectionLevelMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new InspectionLevelMaintMethod(cdo, InspectionLevelMaintMethods.ExecuteTransaction, (InspectionLevelMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        InspectionLevelMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((InspectionLevelMaint) cdo, (InspectionLevelMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(InspectionLevelMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (InspectionLevelMaint_Request) null, out InspectionLevelMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      InspectionLevelMaint_Request request,
      out InspectionLevelMaint_Result result)
    {
      return this.ExecuteTransaction((InspectionLevelMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(InspectionLevelMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new InspectionLevelMaintMethod(cdo, InspectionLevelMaintMethods.AddDataTransaction, (InspectionLevelMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((InspectionLevelMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
