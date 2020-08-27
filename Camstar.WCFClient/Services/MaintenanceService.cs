// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MaintenanceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class MaintenanceService : UpdateBase
  {
    public MaintenanceService(UserProfile userProfile)
    {
      this.Initialize(typeof (IMaintenanceService), userProfile);
    }

    public ResultStatus AddMassUpdateStatement(
      Maintenance maintenance,
      Maintenance_AddMassUpdateStatement_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (AddMassUpdateStatement), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).AddMassUpdateStatement(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.AddMassUpdateStatement, (Maintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddMassUpdateStatement), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddMassUpdateStatement()
    {
      return this.AddMassUpdateStatement((Maintenance) null, (Maintenance_AddMassUpdateStatement_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus AddMassUpdateStatement(Maintenance maintenance)
    {
      return this.AddMassUpdateStatement(maintenance, (Maintenance_AddMassUpdateStatement_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus AddMassUpdateStatement(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.AddMassUpdateStatement(maintenance, (Maintenance_AddMassUpdateStatement_Parameters) null, request, out result);
    }

    public ResultStatus AssignChangePackage(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (AssignChangePackage), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).AssignChangePackage(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.AssignChangePackage, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AssignChangePackage), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AssignChangePackage()
    {
      return this.AssignChangePackage((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus AssignChangePackage(Maintenance maintenance)
    {
      return this.AssignChangePackage(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus AssignChangePackage(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.AssignChangePackage(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus AuthorizeSigner(
      Maintenance maintenance,
      Maintenance_AuthorizeSigner_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (AuthorizeSigner), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).AuthorizeSigner(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.AuthorizeSigner, (Maintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AuthorizeSigner), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AuthorizeSigner()
    {
      return this.AuthorizeSigner((Maintenance) null, (Maintenance_AuthorizeSigner_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus AuthorizeSigner(Maintenance maintenance)
    {
      return this.AuthorizeSigner(maintenance, (Maintenance_AuthorizeSigner_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus AuthorizeSigner(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.AuthorizeSigner(maintenance, (Maintenance_AuthorizeSigner_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).Delete(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Delete(Maintenance maintenance)
    {
      return this.Delete(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Delete(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.Delete(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).DeleteAllRevisions(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus DeleteAllRevisions(Maintenance maintenance)
    {
      return this.DeleteAllRevisions(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.DeleteAllRevisions(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus Execute(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (Execute), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).Execute(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.Execute, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Execute), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Execute()
    {
      return this.Execute((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Execute(Maintenance maintenance)
    {
      return this.Execute(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Execute(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.Execute(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteAdd(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteAdd), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ExecuteAdd(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ExecuteAdd, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteAdd), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteAdd()
    {
      return this.ExecuteAdd((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteAdd(Maintenance maintenance)
    {
      return this.ExecuteAdd(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteAdd(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ExecuteAdd(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteAddRev(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteAddRev), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ExecuteAddRev(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ExecuteAddRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteAddRev), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteAddRev()
    {
      return this.ExecuteAddRev((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteAddRev(Maintenance maintenance)
    {
      return this.ExecuteAddRev(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteAddRev(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ExecuteAddRev(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteChange(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteChange), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ExecuteChange(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ExecuteChange, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteChange), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteChange()
    {
      return this.ExecuteChange((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteChange(Maintenance maintenance)
    {
      return this.ExecuteChange(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteChange(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ExecuteChange(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteDelete(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteDelete), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ExecuteDelete(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ExecuteDelete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteDelete), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteDelete()
    {
      return this.ExecuteDelete((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteDelete(Maintenance maintenance)
    {
      return this.ExecuteDelete(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteDelete(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ExecuteDelete(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ExecuteDeleteAll(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteDeleteAll), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ExecuteDeleteAll(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ExecuteDeleteAll, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteDeleteAll), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ExecuteDeleteAll()
    {
      return this.ExecuteDeleteAll((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteDeleteAll(Maintenance maintenance)
    {
      return this.ExecuteDeleteAll(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteDeleteAll(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ExecuteDeleteAll(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).Freeze(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Freeze(Maintenance maintenance)
    {
      return this.Freeze(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Freeze(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.Freeze(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus GetESigRequirements(
      Maintenance maintenance,
      Maintenance_GetESigRequirements_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (GetESigRequirements), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).GetESigRequirements(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.GetESigRequirements, (Maintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetESigRequirements), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetESigRequirements()
    {
      return this.GetESigRequirements((Maintenance) null, (Maintenance_GetESigRequirements_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus GetESigRequirements(Maintenance maintenance)
    {
      return this.GetESigRequirements(maintenance, (Maintenance_GetESigRequirements_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus GetESigRequirements(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.GetESigRequirements(maintenance, (Maintenance_GetESigRequirements_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).GetWIPMsgs(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus GetWIPMsgs(Maintenance maintenance)
    {
      return this.GetWIPMsgs(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.GetWIPMsgs(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).Load(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Load(Maintenance maintenance)
    {
      return this.Load(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Load(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.Load(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Maintenance maintenance,
      Maintenance_LoadESigDetails_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).LoadESigDetails(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.LoadESigDetails, (Maintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Maintenance) null, (Maintenance_LoadESigDetails_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus LoadESigDetails(Maintenance maintenance)
    {
      return this.LoadESigDetails(maintenance, (Maintenance_LoadESigDetails_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus LoadESigDetails(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.LoadESigDetails(maintenance, (Maintenance_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).New(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus New(Maintenance maintenance)
    {
      return this.New(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus New(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.New(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).NewCopy(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus NewCopy(Maintenance maintenance)
    {
      return this.NewCopy(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus NewCopy(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.NewCopy(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus PostLoad(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (PostLoad), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).PostLoad(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.PostLoad, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PostLoad), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PostLoad()
    {
      return this.PostLoad((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostLoad(Maintenance maintenance)
    {
      return this.PostLoad(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostLoad(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.PostLoad(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus PostLoad_User(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (PostLoad_User), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).PostLoad_User(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.PostLoad_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PostLoad_User), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PostLoad_User()
    {
      return this.PostLoad_User((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostLoad_User(Maintenance maintenance)
    {
      return this.PostLoad_User(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostLoad_User(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.PostLoad_User(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus PostSave(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (PostSave), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).PostSave(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.PostSave, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PostSave), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PostSave()
    {
      return this.PostSave((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostSave(Maintenance maintenance)
    {
      return this.PostSave(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostSave(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.PostSave(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus PostSave_User(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (PostSave_User), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).PostSave_User(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.PostSave_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PostSave_User), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PostSave_User()
    {
      return this.PostSave_User((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostSave_User(Maintenance maintenance)
    {
      return this.PostSave_User(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus PostSave_User(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.PostSave_User(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ProcessElectronicSignatures(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ProcessElectronicSignatures), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ProcessElectronicSignatures(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ProcessElectronicSignatures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessElectronicSignatures), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessElectronicSignatures()
    {
      return this.ProcessElectronicSignatures((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ProcessElectronicSignatures(Maintenance maintenance)
    {
      return this.ProcessElectronicSignatures(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ProcessElectronicSignatures(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ProcessElectronicSignatures(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus RemoveChangePackages(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (RemoveChangePackages), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).RemoveChangePackages(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.RemoveChangePackages, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RemoveChangePackages), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RemoveChangePackages()
    {
      return this.RemoveChangePackages((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus RemoveChangePackages(Maintenance maintenance)
    {
      return this.RemoveChangePackages(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus RemoveChangePackages(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.RemoveChangePackages(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).SaveAs(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus SaveAs(Maintenance maintenance)
    {
      return this.SaveAs(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus SaveAs(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.SaveAs(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus SetChangeHistory(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (SetChangeHistory), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).SetChangeHistory(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.SetChangeHistory, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetChangeHistory), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetChangeHistory()
    {
      return this.SetChangeHistory((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus SetChangeHistory(Maintenance maintenance)
    {
      return this.SetChangeHistory(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus SetChangeHistory(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.SetChangeHistory(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus SetCompletionMessage(
      Maintenance maintenance,
      Maintenance_SetCompletionMessage_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (SetCompletionMessage), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).SetCompletionMessage(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.SetCompletionMessage, (Maintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetCompletionMessage), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetCompletionMessage()
    {
      return this.SetCompletionMessage((Maintenance) null, (Maintenance_SetCompletionMessage_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus SetCompletionMessage(Maintenance maintenance)
    {
      return this.SetCompletionMessage(maintenance, (Maintenance_SetCompletionMessage_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus SetCompletionMessage(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.SetCompletionMessage(maintenance, (Maintenance_SetCompletionMessage_Parameters) null, request, out result);
    }

    public ResultStatus Sync(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (Sync), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).Sync(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.Sync, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Sync), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Sync()
    {
      return this.Sync((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Sync(Maintenance maintenance)
    {
      return this.Sync(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus Sync(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.Sync(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).UnFreeze(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus UnFreeze(Maintenance maintenance)
    {
      return this.UnFreeze(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus UnFreeze(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.UnFreeze(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateAdd(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ValidateAdd), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ValidateAdd(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ValidateAdd, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateAdd), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateAdd()
    {
      return this.ValidateAdd((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateAdd(Maintenance maintenance)
    {
      return this.ValidateAdd(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateAdd(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ValidateAdd(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateAddRev(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ValidateAddRev), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ValidateAddRev(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ValidateAddRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateAddRev), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateAddRev()
    {
      return this.ValidateAddRev((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateAddRev(Maintenance maintenance)
    {
      return this.ValidateAddRev(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateAddRev(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ValidateAddRev(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateChange(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ValidateChange), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ValidateChange(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ValidateChange, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateChange), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateChange()
    {
      return this.ValidateChange((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateChange(Maintenance maintenance)
    {
      return this.ValidateChange(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateChange(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ValidateChange(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateDelete(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ValidateDelete), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ValidateDelete(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ValidateDelete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateDelete), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateDelete()
    {
      return this.ValidateDelete((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateDelete(Maintenance maintenance)
    {
      return this.ValidateDelete(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateDelete(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ValidateDelete(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateDeleteAll(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ValidateDeleteAll), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ValidateDeleteAll(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ValidateDeleteAll, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateDeleteAll), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateDeleteAll()
    {
      return this.ValidateDeleteAll((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateDeleteAll(Maintenance maintenance)
    {
      return this.ValidateDeleteAll(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateDeleteAll(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ValidateDeleteAll(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus ValidateElectronicSignatures(
      Maintenance maintenance,
      Maintenance_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ValidateElectronicSignatures), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ValidateElectronicSignatures(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.ValidateElectronicSignatures, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateElectronicSignatures), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateElectronicSignatures()
    {
      return this.ValidateElectronicSignatures((Maintenance) null, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateElectronicSignatures(Maintenance maintenance)
    {
      return this.ValidateElectronicSignatures(maintenance, (Maintenance_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ValidateElectronicSignatures(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ValidateElectronicSignatures(maintenance, (Maintenance_Parameters) null, request, out result);
    }

    public ResultStatus VerifyPasswordSignature(
      Maintenance maintenance,
      Maintenance_VerifyPasswordSignature_Parameters parameters,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (VerifyPasswordSignature), (DCObject) maintenance, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).VerifyPasswordSignature(this._UserProfile, maintenance, parameters, request, out result) : this.AddMethod((Method) new MaintenanceMethod(maintenance, MaintenanceMethods.VerifyPasswordSignature, (Maintenance_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (VerifyPasswordSignature), res, (DCObject) maintenance, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus VerifyPasswordSignature()
    {
      return this.VerifyPasswordSignature((Maintenance) null, (Maintenance_VerifyPasswordSignature_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus VerifyPasswordSignature(Maintenance maintenance)
    {
      return this.VerifyPasswordSignature(maintenance, (Maintenance_VerifyPasswordSignature_Parameters) null, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus VerifyPasswordSignature(
      Maintenance maintenance,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.VerifyPasswordSignature(maintenance, (Maintenance_VerifyPasswordSignature_Parameters) null, request, out result);
    }

    protected override ResultStatus OnLoad(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Maintenance_Result result1;
        ResultStatus resultStatus = this.Load((Maintenance) maintenance, (Maintenance_Parameters) parameters, (Maintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject maintenance,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Maintenance_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Maintenance) maintenance, (Maintenance_Parameters) parameters, (Maintenance_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      try
      {
        MaintenanceMethod[] methods = new MaintenanceMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IMaintenanceService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Maintenance_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Maintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Maintenance cdo,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      try
      {
        return ((IMaintenanceService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Maintenance_Result result1;
        ResultStatus environment = this.GetEnvironment((Maintenance) cdo, (Maintenance_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.GetEnvironment((Maintenance) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Maintenance cdo,
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      result = (Maintenance_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IMaintenanceService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new MaintenanceMethod(cdo, MaintenanceMethods.ExecuteTransaction, (Maintenance_Parameters) null));
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
        Maintenance_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Maintenance) cdo, (Maintenance_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Maintenance cdo)
    {
      return this.ExecuteTransaction(cdo, (Maintenance_Request) null, out Maintenance_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Maintenance_Request request,
      out Maintenance_Result result)
    {
      return this.ExecuteTransaction((Maintenance) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Maintenance cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new MaintenanceMethod(cdo, MaintenanceMethods.AddDataTransaction, (Maintenance_Parameters) null));
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
        return this.AddDataTransaction((Maintenance) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
