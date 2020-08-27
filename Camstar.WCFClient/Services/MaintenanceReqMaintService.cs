// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceReqMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaintenanceReqMaintService : RevisionedObjectMaintBase
  {
    public MaintenanceReqMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaintenanceReqMaintService), userProfile);
    }

    public ResultStatus Delete(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).Delete(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus Delete(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.Delete(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus Delete(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.Delete(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.DeleteAllRevisions(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.DeleteAllRevisions(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).Freeze(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus Freeze(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.Freeze(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus Freeze(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.Freeze(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).GetWIPMsgs(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.GetWIPMsgs(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.GetWIPMsgs(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).Load(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus Load(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.Load(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus Load(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.Load(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_LoadESigDetails_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).LoadESigDetails(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.LoadESigDetails, (MaintenanceReqMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((MaintenanceReqMaint) null, (MaintenanceReqMaint_LoadESigDetails_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.LoadESigDetails(maintenanceReqMaint, (MaintenanceReqMaint_LoadESigDetails_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.LoadESigDetails(maintenanceReqMaint, (MaintenanceReqMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).New(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus New(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.New(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus New(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.New(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).NewCopy(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus NewCopy(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.NewCopy(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus NewCopy(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.NewCopy(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).NewRev(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus NewRev(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.NewRev(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus NewRev(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.NewRev(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).NewRevCopy(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.NewRevCopy(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.NewRevCopy(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).SaveAs(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus SaveAs(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.SaveAs(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus SaveAs(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.SaveAs(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).SaveAsRev(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.SaveAsRev(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.SaveAsRev(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Parameters parameters,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).UnFreeze(this._UserProfile, maintenanceReqMaint, parameters, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(maintenanceReqMaint, MaintenanceReqMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) maintenanceReqMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((MaintenanceReqMaint) null, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus UnFreeze(MaintenanceReqMaint maintenanceReqMaint)
    {
      return this.UnFreeze(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus UnFreeze(
      MaintenanceReqMaint maintenanceReqMaint,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.UnFreeze(maintenanceReqMaint, (MaintenanceReqMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.Delete((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_LoadESigDetails_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.New((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.Load((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject maintenanceReqMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        MaintenanceReqMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((MaintenanceReqMaint) maintenanceReqMaint, (MaintenanceReqMaint_Parameters) parameters, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      try
      {
        MaintenanceReqMaintMethod[] methods = new MaintenanceReqMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaintenanceReqMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceReqMaint cdo,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      try
      {
        return ((IMaintenanceReqMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        MaintenanceReqMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((MaintenanceReqMaint) cdo, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.GetEnvironment((MaintenanceReqMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceReqMaint cdo,
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      result = (MaintenanceReqMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceReqMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaintenanceReqMaintMethod(cdo, MaintenanceReqMaintMethods.ExecuteTransaction, (MaintenanceReqMaint_Parameters) null));
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
        MaintenanceReqMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((MaintenanceReqMaint) cdo, (MaintenanceReqMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(MaintenanceReqMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (MaintenanceReqMaint_Request) null, out MaintenanceReqMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      MaintenanceReqMaint_Request request,
      out MaintenanceReqMaint_Result result)
    {
      return this.ExecuteTransaction((MaintenanceReqMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(MaintenanceReqMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaintenanceReqMaintMethod(cdo, MaintenanceReqMaintMethods.AddDataTransaction, (MaintenanceReqMaint_Parameters) null));
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
        return this.AddDataTransaction((MaintenanceReqMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
